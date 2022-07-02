using System.ComponentModel.DataAnnotations;

public class Story
{
    [Key]
    public int ID { get; set;}

    public string? Noun1 { get; set;}
//    [DisplayName("NOUN - report card grade")]

    public string? Noun2 { get; set;}
//    [DisplayName("NOUN - a person")]

    public string? Noun3 { get; set;}
//    [DisplayName("NOUN - a number")]

    public string? Noun4 { get; set;}
//    [DisplayName("NOUN - a number ")]

    public string? Noun5 { get; set;}
//    [DisplayName("Name - a number")]

    public string? Noun6 { get; set;}
//    [DisplayName("NOUN - a container")]

    public string? Noun7 { get; set;}
//    [DisplayName("NOUN - a place")]

    public string? Noun8 { get; set;}
//    [DisplayName("NOUN - measure of time")]

    public string? Verb { get; set;}
//    [DisplayName("VERB - a chore")]

    public string? Adjective { get; set;}
//    [DisplayName("ADJECTIVE - a size")]  
}