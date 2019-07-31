using System;
using System.Collections.Generic;

namespace Challenges.DrawingBook
{
    public class Book
    {
        public int PageCount { get; private set; }

        public Book(int pageCount)
        {
            if (pageCount <= 0)
                throw new ArgumentOutOfRangeException("Invalid count of pages");

            this.PageCount = pageCount;
        }

        public int TurnToPage(int pageNumber)
        {
            if (pageNumber == 0 || pageNumber > this.PageCount)
                throw new ArgumentOutOfRangeException("Page number does not exist within the bounds of the book");

            return Math.Min(pageNumber / 2, (this.PageCount / 2) - (pageNumber / 2));
        }
    }
}
