using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("31.570771,-84.10353,Taco Bell Albany/... (Free trial * Add to Cart for a full POI info)", "Taco Bell Albany/... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.324462,-86.503055,Taco Bell Ara... (Free trial * Add to Cart for a full POI info)", "Taco Bell Ara... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha... (Free trial * Add to Cart for a full POI info)", "Taco Bell Birmingha... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("33.145076,-86.749777,Taco Bell Caler... (Free trial * Add to Cart for a full POI info)", "Taco Bell Caler... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill... (Free trial * Add to Cart for a full POI info)", "Taco Bell Adairsvill... (Free trial * Add to Cart for a full POI info)")]
        public void ShouldParse(string str, string expected)
        {
            // TODO: Complete Should Parse
            //Arrange
            TacoParser challenger = new TacoParser();
            //Act
            ITrackable actual = challenger.Parse(str);
            //Assert
            Assert.Equal(actual.Name, expected);
        }


        [Theory]
        
        [InlineData(null)]
        [InlineData("")]
        [InlineData("31.570771,Taco Bell Albany/... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("-86.503055,Taco Bell Ara... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("33.556383,-86.889051")]
        [InlineData("33.145076,Taco Bell Caler... (Free trial * Add to Cart for a full POI info)")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse
            //Arrange
            TacoParser challenger = new TacoParser();
            //Act
            ITrackable actual = challenger.Parse(str);
            //Assert
            Assert.Null(actual);
        }
    }
}
