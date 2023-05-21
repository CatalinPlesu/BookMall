using BookMall.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BookMall.Web.Models
{
    class PDbTableBuilder
    {
        private PDbTable _data;

        public PDbTableBuilder()
        {
            _data = new PDbTable();
        }

        public PDbTableBuilder SetOwnerId(int ownerId)
        {
            _data.OwnerId = ownerId;
            return this;
        }

        public PDbTableBuilder SetTitle(string title)
        {
            _data.Title = title;
            return this;
        }

        public PDbTableBuilder SetAuthor(string author)
        {
            _data.Author = author;
            return this;
        }

        public PDbTableBuilder SetGenre(string genre)
        {
            _data.Genre = genre;
            return this;
        }

        public PDbTableBuilder SetImageUrl(string imageUrl)
        {
            _data.ImageUrl = imageUrl;
            return this;
        }

        public PDbTableBuilder SetPdfUrl(string pdfUrl)
        {
            _data.PdfUrl = pdfUrl;
            return this;
        }

        public PDbTableBuilder SetJpgFile(string jpgFile)
        {
            _data.JpgFile = jpgFile;
            return this;
        }

        public PDbTableBuilder SetPdfFile(string pdfFile)
        {
            _data.PdfFile = pdfFile;
            return this;
        }

        public PDbTableBuilder SetPrice(float price)
        {
            _data.Price = price;
            return this;
        }

        public PDbTableBuilder SetPages(int pages)
        {
            _data.Pages = pages;
            return this;
        }

        public PDbTableBuilder SetISBN(string isbn)
        {
            _data.ISBN = isbn;
            return this;
        }

        public PDbTable Build()
        {
            return _data;
        }
    }
}