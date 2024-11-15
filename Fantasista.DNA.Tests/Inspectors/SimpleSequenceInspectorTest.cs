using Fantasista.DNA.FastaFile;
using Fantasista.DNA.Sequence;
using Fantasista.DNA.Sequence.Inspectors;

namespace Fantasista.DNA.Tests.Inspectors;

public class SimpleSequenceInspectorTest
{
    [Fact]
    public void DNA_is_guessed_correctly()
    {
        var basicSequence = new BasicSequence("test", "ATGGCCTAGA");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.DNA,result.GuessedType);
    }

    [Fact]
    public void RNA_is_guessed_correctly()
    {
        var basicSequence = new BasicSequence("test", "AUGGCCUAGA");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.RNA,result.GuessedType);
    }

    [Fact]
    public void Protein_is_guessed_correctly()
    {
        var basicSequence = new BasicSequence("test", "MKWVTFISLLLLFSSAYS");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.Protein,result.GuessedType);
    }

    [Fact]
    public void Empty_sequence_is_guessed_as_unknown()
    {
        var basicSequence = new BasicSequence("test", "");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.Unknown,result.GuessedType);
    }

    [Fact]
    public void Long_protein_sequence_is_guessed_correctly()
    {
        var basicSequence = new BasicSequence("test", "MALWMRLLPLLALLALWGPDPAAAFVNQHLCGSHLVEALYLVCGERGFFYTPKTRREAEDLQVGQVELGGGPGAGSLQPLALEGSLQKRGIVEQCCTSICSLYQLENYCN");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.Protein,result.GuessedType);
    }

    [Fact]
    public void Long_protein_that_is_also_valid_dna_sequence_is_guessed_correctly()
    {
        var basicSequence = new BasicSequence("test", "GAAGGAGAAGGAGAAGGAGAAGGAGAAGGA");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.Protein,result.GuessedType);
    }

    [Fact]
    public void Nonsensical_sequence_is_guessed_as_unknown()
    {
        var basicSequence = new BasicSequence("test", "ANSMDNAMS9Q");
        var inspector = new SimpleSequenceInspector();
        var result = inspector.InspectSequence(basicSequence);
        Assert.Equal(SequenceType.Unknown,result.GuessedType);
    }
    
}