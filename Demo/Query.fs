namespace Demo

type Query() =
    member this.Book =
        new Book("F#", new Author("Jon"))

