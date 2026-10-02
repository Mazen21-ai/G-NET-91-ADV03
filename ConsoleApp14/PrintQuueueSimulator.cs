using System;
using System.Collections.Generic;

public class PrintQueueSimulator
{
    public static void Run()
    {
        Queue<string> documents = new Queue<string>();

        documents.Enqueue("Report.pdf");
        documents.Enqueue("Invoice.pdf");
        documents.Enqueue("Letter.docx");
        documents.Enqueue("Resume.pdf");
        documents.Enqueue("Photo.jpg");

        Console.WriteLine("Queue: " +
            string.Join(", ", documents));

        Console.WriteLine("Count: " + documents.Count);

        Console.WriteLine("Next document: " + documents.Peek());

        while (documents.Count > 0)
        {
            string document = documents.Dequeue();

            Console.WriteLine("Printing: " + document);
        }

        bool success = documents.TryDequeue(out string documentAfter);

        Console.WriteLine("TryDequeue succeeded: " + success);

        Console.WriteLine("Returned document: " +
            (documentAfter ?? "null"));
    }
}