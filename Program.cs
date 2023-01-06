// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

    using FactoryMethod;

    Pasteles pastel = Creador.CreadorPasteles(Creador.SELVANEGRA);
    Console.WriteLine(pastel.pastelesSemanales());
