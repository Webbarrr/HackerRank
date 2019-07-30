using System;
using System.Collections.Generic;

namespace Challenges.DrawingBook
{
    public class Book
    {
        public int PageCount { get; private set; }
        public int TurnCount { get; private set; }

        public readonly List<Page> pages;

        public Book(int pageCount)
        {
            if (pageCount <= 0)
                throw new InvalidOperationException("Invalid count of pages");

            this.PageCount = pageCount;

            this.pages = new List<Page>();

            // add the pages
            for (int i = 0; i <= pageCount; i+=2)
                this.pages.Add(new Page{LeftPage = i, RightPage = i+1});
        }

        public int TurnToPage(int pageNumber)
        {
            if (pageNumber == 0 || pageNumber > this.PageCount)
                throw new ArgumentOutOfRangeException("Page number does not exist within the bounds of the book");



            return pageNumber == 1 ? 0 
                : pageNumber == this.PageCount ? 0 
                : Math.Min(this.TurnFromFront(pageNumber)
                    , this.TurnFromBack(pageNumber));
        }

        private int TurnFromFront(int pageNumber)
        {
            var turnCount = 0;

            foreach (var page in this.pages)
            {
                if (page.LeftPage == pageNumber || page.RightPage == pageNumber)
                    return turnCount;

                turnCount++;
            }

            return turnCount;
        }

        private int TurnFromBack(int pageNumber)
        {
            this.pages.Reverse();
            var turnCount = 0;

            foreach (var page in this.pages)
            {
                if (page.LeftPage == pageNumber || page.RightPage == pageNumber)
                    return turnCount;

                turnCount++;
            }

            return turnCount;
        }

    }

    public class Page
    {
        public int LeftPage { get; set; }
        public int RightPage { get; set; }
    }
}
