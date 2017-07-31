using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;

    public Library(params Book[] books)
    {
        this.books = new SortedSet<Book>(books);
    }


    public IEnumerator<Book> GetEnumerator()
    {
        // yield keyword makes easier to implement the GetEnumerator method
        //the commented out code leads to the same results as the custom made LibraryIterator
        //for (int i = 0; i < this.books.Count; i++)
        //{
        //    yield return this.books[i];
        //}

        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.currentIndex++;
            return this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;
    }
}