﻿using Fantasista.DNA.FastaFile;
using Fantasista.DNA.FastaFile.Inspectors;
using Fantasista.DNA.Sequence;
using Moq;

namespace Fantasista.DNA.Tests;

public class FastaStreamReaderTest
{
    [Fact]
    public void Read_a_simple_sequence_works_without_problems()
    {
        var text = ">SEQUENCE_1\nMTEITAAMVKELRESTGAGMMDCKNALSETNGDFDKAVQLLREKGLGKAAKKADRLAAEG\nLVSVKVSDDFTIAAMRPSYLSYEDLDMTFVENEYKALVAELEKENEERRRLKDPNKPEHK\nIPQFASRKQLSDAILKEAEEKIKEELKAQGKPEKIWDNIIPGKMNSFIADNSQLDSKLTL\nMGQFYVMDDKKTVEQVIAEKEKEFGGKIKIVEFICFEVGEGLEKKTEDFAAEVAAQL";
        var fastaReader = new FastaStreamReader(text);
        var a = fastaReader.Read().ToArray();
        Assert.Equal("SEQUENCE_1",a[0].Identifier);
        Assert.Equal("MTEITAAMVKELRESTGAGMMDCKNALSETNGDFDKAVQLLREKGLGKAAKKADRLAAEGLVSVKVSDDFTIAAMRPSYLSYEDLDMTFVENEYKALVAELEKENEERRRLKDPNKPEHKIPQFASRKQLSDAILKEAEEKIKEELKAQGKPEKIWDNIIPGKMNSFIADNSQLDSKLTLMGQFYVMDDKKTVEQVIAEKEKEFGGKIKIVEFICFEVGEGLEKKTEDFAAEVAAQL",a[0].RawSequence);
    }
    
    [Fact]
    public void Read_two_simple_sequences_works_without_problems()
    {
        var text = ">SEQUENCE_1\nMTEITAAMVKELRESTGAGMMDCKNALSETNGDFDKAVQLLREKGLGKAAKKADRLAAEG\nLVSVKVSDDFTIAAMRPSYLSYEDLDMTFVENEYKALVAELEKENEERRRLKDPNKPEHK\nIPQFASRKQLSDAILKEAEEKIKEELKAQGKPEKIWDNIIPGKMNSFIADNSQLDSKLTL\nMGQFYVMDDKKTVEQVIAEKEKEFGGKIKIVEFICFEVGEGLEKKTEDFAAEVAAQL\n>SEQUENCE_2\nSATVSEINSETDFVAKNDQFIALTKDTTAHIQSNSLQSVEELHSSTINGVKFEEYLKSQI\nATIGENLVVRRFATLKAGANGVVNGYIHTNGRVGVVIAAACDSAEVASKSRDLLRQICMH";
        using var fastaReader = new FastaStreamReader(text);
        var a = fastaReader.Read().ToArray();
        Assert.Equal("SEQUENCE_1",a[0].Identifier);
        Assert.Equal("MTEITAAMVKELRESTGAGMMDCKNALSETNGDFDKAVQLLREKGLGKAAKKADRLAAEGLVSVKVSDDFTIAAMRPSYLSYEDLDMTFVENEYKALVAELEKENEERRRLKDPNKPEHKIPQFASRKQLSDAILKEAEEKIKEELKAQGKPEKIWDNIIPGKMNSFIADNSQLDSKLTLMGQFYVMDDKKTVEQVIAEKEKEFGGKIKIVEFICFEVGEGLEKKTEDFAAEVAAQL",a[0].RawSequence);
        Assert.Equal("SEQUENCE_2",a[1].Identifier);
        Assert.Equal("SATVSEINSETDFVAKNDQFIALTKDTTAHIQSNSLQSVEELHSSTINGVKFEEYLKSQIATIGENLVVRRFATLKAGANGVVNGYIHTNGRVGVVIAAACDSAEVASKSRDLLRQICMH",a[1].RawSequence);
    }

    [Fact]
    public void Inspector_is_called_when_using_inspectedd_reads()
    {
        var text = ">SEQUENCE_1\nMTEITAAMVKELRESTGAGMMDCKNALSETNGDFDKAVQLLREKGLGKAAKKADRLAAEG\nLVSVKVSDDFTIAAMRPSYLSYEDLDMTFVENEYKALVAELEKENEERRRLKDPNKPEHK\nIPQFASRKQLSDAILKEAEEKIKEELKAQGKPEKIWDNIIPGKMNSFIADNSQLDSKLTL\nMGQFYVMDDKKTVEQVIAEKEKEFGGKIKIVEFICFEVGEGLEKKTEDFAAEVAAQL\n>SEQUENCE_2\nSATVSEINSETDFVAKNDQFIALTKDTTAHIQSNSLQSVEELHSSTINGVKFEEYLKSQI\nATIGENLVVRRFATLKAGANGVVNGYIHTNGRVGVVIAAACDSAEVASKSRDLLRQICMH";
        using var fastaReader = new FastaStreamReader(text);
        var inspector = new Mock<ISequenceInspector<BasicSequence>>();
        var a = fastaReader.ReadInspected(inspector.Object).ToArray();
        inspector.Verify(x=>x.InspectSequence(It.IsAny<BasicSequence>()), Times.Exactly(2));        
    }
    
    
}