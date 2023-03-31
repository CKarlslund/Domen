using Domen.Domain;
using Ganss.Excel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Domen.Application
{
    public class ExcelService
    {
        public ExcelService()
        {
        }

        public IEnumerable<GroupInformation> ConvertToGroupInformation(string path)
        {
            var excelMapper = new ExcelMapper(path);
            var groupInformationList = excelMapper.Fetch<GroupInformation>();

            var filteredGroups = groupInformationList.Where(gi => gi.AlreadyUpdated != "JA");

            return filteredGroups;
        }

        public IEnumerable<UserInformation> ConvertToUserInformation(string path)
        {
            var excelMapper = new ExcelMapper(path);
            var userInformationList = excelMapper.Fetch<UserInformation>();

            return userInformationList;
        }

        public Document ConvertToWordDocument(IEnumerable<GroupInformation> groupInformationList)
        {
            var doc = new Document();

            var section1 = doc.AddSection();
            var scenariosWantedList = groupInformationList
                .Where(gi => gi.ScenarioWanted == "Ja")
                .OrderBy(gi => gi.NameInGame);

            var scenariosNotWantedList = groupInformationList
                .Where(gi => gi.ScenarioWanted == "Nej")
                .OrderBy(gi => gi.NameInGame);


            foreach (var groupInformation in scenariosWantedList)
            {
                WriteParagraphs(groupInformation, section1);
            }

            var section2 = doc.AddSection();

            section2.AddParagraph();
            var title = section2.AddParagraph().AppendText("Ingen intriganmälan");
            title.CharacterFormat.FontSize = 15;
            title.CharacterFormat.Bold = true;
            section2.AddParagraph();

            foreach (var groupInformation in scenariosNotWantedList)
            {
                WriteParagraphs(groupInformation, section2);
            }

            return doc;
        }

        public string SaveToFile(string filePath, Document document)
        {
            try
            {
                document.SaveToFile(filePath);
                return $"Fil sparad i {filePath}";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return $"Något gick fel! Ge den här felkoden till Cornelia: \n {e.Message}";
            }
        }

        private static void WriteParagraphs(GroupInformation groupInformation, Section section)
        {
            var paragraph2 = section.AddParagraph();
            var title2 = paragraph2.AppendText("Gruppens inlajvnamn: ");
            title2.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title2.CharacterFormat.FontSize = 12;
            title2.CharacterFormat.Bold = true;
            paragraph2.AppendText(groupInformation.NameInGame);

            var emailAddressParagraph = section.AddParagraph();
            var emailAddressParagraphTitle = emailAddressParagraph.AppendText("Emailadress: ");
            emailAddressParagraphTitle.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            emailAddressParagraphTitle.CharacterFormat.FontSize = 12;
            emailAddressParagraphTitle.CharacterFormat.Bold = true;
            emailAddressParagraph.AppendText(groupInformation.Email);

            var groupTypeParagraph = section.AddParagraph();
            var groupTypeParagraphTitle = groupTypeParagraph.AppendText("Grupptyp: ");
            groupTypeParagraphTitle.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            groupTypeParagraphTitle.CharacterFormat.FontSize = 12;
            groupTypeParagraphTitle.CharacterFormat.Bold = true;
            groupTypeParagraph.AppendText(groupInformation.GroupType);

            var paragraph3 = section.AddParagraph();
            var title3 = paragraph3.AppendText($"Kort beskrivning: ");
            title3.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title3.CharacterFormat.FontSize = 11;
            title3.CharacterFormat.Bold = true;
            paragraph3.AppendText(groupInformation.Description);

            var paragraph4 = section.AddParagraph();
            var title4 = paragraph4.AppendText($"Viktigt för arr att veta:: ");
            title4.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title4.CharacterFormat.FontSize = 11;
            title4.CharacterFormat.Bold = true;
            paragraph4.AppendText(groupInformation.GoodToKnow);

            var paragraph5 = section.AddParagraph();
            var title5 = paragraph5.AppendText($"Vänner: ");
            title5.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title5.CharacterFormat.FontSize = 11;
            title5.CharacterFormat.Bold = true;
            paragraph5.AppendText(groupInformation.Friends);

            var paragraph6 = section.AddParagraph();
            var title6 = paragraph6.AppendText($"Fiender: ");
            title6.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title6.CharacterFormat.FontSize = 11;
            title6.CharacterFormat.Bold = true;
            paragraph6.AppendText(groupInformation.Enemies);

            var paragraph7 = section.AddParagraph();
            var title7 = paragraph7.AppendText($"Typ av spel: ");
            title7.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title7.CharacterFormat.FontSize = 11;
            title7.CharacterFormat.Bold = true;
            paragraph7.AppendText(groupInformation.TypeOfRoleplayRequest);

            var paragraph8 = section.AddParagraph();
            var title8 = paragraph8.AppendText($"Intrig: ");
            title8.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title8.CharacterFormat.FontSize = 11;
            title8.CharacterFormat.Bold = true;

            var paragraph9 = section.AddParagraph();
            var title9 = paragraph9.AppendText($"Rykten till gruppen: ");
            title9.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title9.CharacterFormat.FontSize = 11;
            title9.CharacterFormat.Bold = true;

            section.AddParagraph();
            var breaker = section.AddParagraph();
            breaker.AppendText("—----------------------------------------------");
            section.AddParagraph();
        }

        public List<Document> ConvertToDocs(IEnumerable<GroupInformation> groupInformationList)
        {
            throw new NotImplementedException();
        }
    }
}