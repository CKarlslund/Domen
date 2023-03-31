using System.Xml.XPath;
using AutoFixture.Xunit2;
using Domen.Application;
using Domen.Domain;
using FluentAssertions;

namespace Domen.UI.UnitTests
{
    public class ExcelServiceTest
    {
        private readonly ExcelService _excelService;
            
        public ExcelServiceTest()
        {
            _excelService = new ExcelService();
        }

        [Fact]
        public void Should_convert_to_groupInformation()
        {
            const string path = "ExcelExample.xlsx";

            var result = _excelService.ConvertToGroupInformation(path).ToList();

            result.FirstOrDefault()?.NameOffGame.Should().Be("Härbärget");

            foreach (var groupInformation in result)
            {
                groupInformation.AlreadyUpdated.Should().NotBe("JA");
            }
        }

        [Fact]
        public void Should_convert_to_userInformation()
        {
            const string path = "UserExcelExample.xlsx";

            var result = _excelService.ConvertToUserInformation(path).ToList();

            result.FirstOrDefault()?.Email.Should().Be("cornelia.karlslund@gmail.com");
            result.Count().Should().Be(39);
        }

        [Theory]
        [AutoData]
        public void Should_convert_to_word_file(List<GroupInformation> groupInformationList)
        {
            groupInformationList.FirstOrDefault()!.ScenarioWanted = "Ja";
            groupInformationList.LastOrDefault()!.ScenarioWanted = "Nej";

            var result = _excelService.ConvertToWordDocument(groupInformationList);

            result.Sections.Count.Should().Be(2);
            result.Sections[0].Paragraphs.Count.Should().Be(11);
            result.Sections[0].Paragraphs.Count.Should().Be(11);
            result.Sections[0].Paragraphs[0].Text.Should().Contain(groupInformationList.FirstOrDefault()!.NameInGame);
        }
    }
}