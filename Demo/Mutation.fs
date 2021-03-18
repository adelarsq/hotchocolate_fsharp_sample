namespace Demo

type Mutation() =
    member this.CreateBook (book:Book) =
        new Book("F#", new Author("Jon"))

