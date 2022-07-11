using System.ComponentModel.DataAnnotations;

public class StoryB
{
    [Key]
    public int ID { get; set; }

    [Display(Name = "NOUN: An animal")]
    public string? Noun1 { get; set; }

    [Display(Name = "NOUN: plural things")]
    public string? Noun2 { get; set; }

    [Display(Name = "NOUN: plural things")]
    public string? Noun3 { get; set; }

    [Display(Name = "NOUN: plural things ")]
    public string? Noun4 { get; set; }

    [Display(Name = "NOUN: An animal")]
    public string? Noun5 { get; set; }

    [Display(Name = "NOUN: place")]
    public string? Noun6 { get; set; }

    [Display(Name = "NOUN: place")]
    public string? Noun7 { get; set; }

    [Display(Name = "ADJECTIVE:")]
    public string? Adjective1 { get; set; }
 
    [Display(Name = "ADJECTIVE")]
    public string? Adjective2 { get; set; }
    
    [Display(Name = "ADJECTIVE")]
    public string? Adjective3 { get; set; }

    [Display(Name = "VERB: past tense")]   
    public string? Verb1 { get; set; } 

    [Display(Name = "VERB: emotion")]
    public string? Verb2 { get; set; }
 
    [Display(Name = "VERB: past tense")]   
    public string? Verb3 { get; set; }   

    [Display(Name = "VERB: past tense")]
    public string? Verb4 { get; set; }

    [Display(Name = "VERB: action")]
    public string? Verb5 { get; set; }

    [Display(Name = "VERB: past tense")]
    public string? Verb6 { get; set; }

    [Display(Name = "INTERJECTION: exclaimation")]
    public string? Interjection { get; set; } 
}