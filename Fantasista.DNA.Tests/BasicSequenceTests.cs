using Fantasista.DNA.Sequence;

namespace Fantasista.DNA.Tests;

public class BasicSequenceTests
{
    [Fact]
    public void It_should_give_correct_number_of_unique_characters()
    {
        var sequence = new BasicSequence("test", "AABBCCCCD", "test", "EEFFGGGGH");
        var distinct = sequence.UniqueCharacters.ToArray();
        
        Assert.Equal(4, distinct.Length);
        Assert.Equal("ABCD", new string(distinct));
        
        var distinctQ = sequence.UniqueQualityCharacters.ToArray();
        Assert.Equal(4, distinctQ.Length);
        Assert.Equal("EFGH", new string(distinctQ));        
    }
    
    [Fact]
    public void It_should_give_empty_uniquequalitycharacters_ienumerable_if_quality_is_null()
    {
        var sequence = new BasicSequence("test", "AABBCCCCD", null, null);
        var distinct = sequence.UniqueCharacters.ToArray();
        
        var distinctQ = sequence.UniqueQualityCharacters.ToArray();
        Assert.Equal(0, distinctQ.Length);
        Assert.Equal("", new string(distinctQ));        
    }

    [Fact]
    public void It_should_give_correct_frequencies_for_sequence_and_quality()
    {
        var sequence = new BasicSequence("test", "AAABBCCCCD", "test", "EEEFFGGGGH");
        var fre = sequence.CharacterFrequency;
        
        Assert.Equal(4, fre.Count);
        Assert.Equal('C',fre[0].Character);
        Assert.Equal(4,fre[0].Frequency);
        Assert.Equal('A',fre[1].Character);
        Assert.Equal(3,fre[1].Frequency);
        Assert.Equal('B',fre[2].Character);
        Assert.Equal(2,fre[2].Frequency);
        Assert.Equal('D',fre[3].Character);
        Assert.Equal(1,fre[3].Frequency);
     
        var freQ = sequence.QualityFrequency;
        Assert.Equal(4, freQ.Count);
        Assert.Equal('G',freQ[0].Character);
        Assert.Equal(4,freQ[0].Frequency);
        Assert.Equal('E',freQ[1].Character);
        Assert.Equal(3,freQ[1].Frequency);
        Assert.Equal('F',freQ[2].Character);
        Assert.Equal(2,freQ[2].Frequency);
        Assert.Equal('H',freQ[3].Character);
        Assert.Equal(1,freQ[3].Frequency);
        
    }

    [Fact]
    public void It_should_return_the_correct_length_for_sequence_and_quality()
    {
        var sequence = new BasicSequence("test", "AAABBCCCCD", "test", "EEEFFGGGGH");
        Assert.Equal(10, sequence.SequenceLength);
        Assert.Equal(10, sequence.QualityLength);
    }

    [Fact]
    public void It_should_return_0_as_length_when_rawquality_is_null()
    {
        var sequence = new BasicSequence("test", "AAABBCCCCD", null,null);
        Assert.Equal(10, sequence.SequenceLength);
        Assert.Equal(0, sequence.QualityLength);
    }
    
    
}