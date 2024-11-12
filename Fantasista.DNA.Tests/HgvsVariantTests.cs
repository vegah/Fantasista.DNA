namespace Fantasista.DNA.Tests;

public class HgvsVariantTests
{
    [Fact]
    public void Encoded_string_is_printed_as_original_string()
    {
        var str = "NM_000018.4(ACADVL):c.62+5G>A";
        var variant = HgvsVariant.Parse(str);
        Assert.Equal(str, variant.ToString());
    }
}