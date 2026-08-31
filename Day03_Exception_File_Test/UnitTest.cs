using Day03_Exception_File;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace Day03_Exception_File_Test;

public class Tests
{

    [Test]
    public void No_txt_에_들어_있는_내용을_Yes_txt_에_붙여넣기()
    {
        File.WriteAllText("Yes.txt", "Yes");
        File.WriteAllText("No.txt", "No");

        DefaultFileCopier copier = new DefaultFileCopier();

        copier.CopyFile("No.txt", "Yes.txt");

        string result = File.ReadAllText("Yes.txt");

        Assert.That(result, Is.EqualTo("YesNo"));
        Console.WriteLine(result);
    }
}