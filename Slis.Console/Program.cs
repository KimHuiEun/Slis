using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Slis.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var filePathes = Directory.GetFiles(@"C:\Users\kcci\Desktop\도서관정보 필터링 완료", "*.txt");

            foreach (var filePath in filePathes)
            {
                string fileName = Path.GetFileName(filePath);
                string[] tokens = fileName.Split('_');
                int libraryId = int.Parse(tokens[0]);
                ProcessFile(filePath, libraryId);
            }

        }

        private static void ProcessFile(string filePath, int libraryId)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = "\t";

                List<BookItem> books = csv.GetRecords<BookItem>().ToList();

                foreach (var book in books)
                {
                    ProcessLine(book, libraryId);
                }
            }

            File.Delete(filePath);
        }

        private static void ProcessLine(BookItem book, int libraryId)
        {
            try
            {
                Console.WriteLine($"Inserting...[ISBN]:{book.Isbn}, [LibraryId]:{libraryId}");
                // Book 테이블에 없으면 추가
                if (Dao.Book.Exists(book.Isbn) == false)
                {
                    Book book1 = new Book();
                    book1.Isbn = book.Isbn;
                    book1.SetIsbn = book.SetIsbn;
                    book1.Title = book.Title;
                    book1.Author = book.Author;
                    book1.Publisher = book.Publisher;
                    book1.PublicationDate = book.Year;
                    book1.Kdc = book.Kdc;
                    Dao.Book.Insert(book1);
                }

                // Own 테이블에 없으면 추가
                if (Dao.Own.Exists(book.Isbn, libraryId) == false)
                {
                    Own own = new Own();
                    own.Isbn = book.Isbn;
                    own.LibraryId = libraryId;
                    own.CopyCount = book.CopyCount;
                    own.RentCount = book.RentCount;
                    Dao.Own.Insert(own);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }

    public class BookItem
    {
        [Name("ISBN")]
        public string Isbn { get; set; }
        [Name("세트 ISBN")]
        public string SetIsbn { get; set; }
        [Name("도서명")]
        public string Title { get; set; }
        [Name("저자")]
        public string Author { get; set; }
        [Name("출판사")]
        public string Publisher { get; set; }
        [Name("발행년도")]
        public int Year { get; set; }
        [Name("주제분류번호")]
        public string Kdc { get; set; }
        [Name("도서권수")]
        public int CopyCount { get; set; }
        [Name("대출건수")]
        public int RentCount { get; set; }
    }
}
