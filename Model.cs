using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Model
{
    public List<Book> Books { get; set; }
    private string filePath = "books.json";

    public Model()
    {
        Books = LoadBooks();

    }

    public List<Book> LoadBooks()
    {
        if (File.Exists(filePath))
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Book>>(jsonString) ?? new List<Book>();
        }
        else
        {
            return new List<Book>();
        }
    }
    public void SaveBooks()
    {
        var jsonString = JsonSerializer.Serialize(Books, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }
}