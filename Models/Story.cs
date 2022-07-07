using System.ComponentModel.DataAnnotations;

public class Story
{
    [Key]
    public int ID { get; set; }

    [Display(Name = "NOUN: report card grade")]
    public string? Noun1 { get; set; }

    [Display(Name = "NOUN: person")]
    public string? Noun2 { get; set; }

    [Display(Name = "NOUN: number")]
    public string? Noun3 { get; set; }

    [Display(Name = "NOUN: number ")]
    public string? Noun4 { get; set; }

    [Display(Name = "NOUN: number")]
    public string? Noun5 { get; set; }

    [Display(Name = "NOUN: container")]
    public string? Noun6 { get; set; }

    [Display(Name = "NOUN: place")]
    public string? Noun7 { get; set; }

    [Display(Name = "ADJECTIVE: a size")]
    public string? Adjective { get; set; }

    [Display(Name = "NOUN: measure of time")]
    public string? Noun8 { get; set; }
 
    [Display(Name = "VERB: a chore")]   
    public string? Verb { get; set; }   
}