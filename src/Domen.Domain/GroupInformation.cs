
using Ganss.Excel;

namespace Domen.Domain
{
    public class GroupInformation
    {
        [Column(1)]
        public string Timestamp { get; set; }

        [Column(2)]
        public string Email { get; set; }

        [Column(3)]
        public string NameOffGame { get; set; }

        [Column(4)]
        public string NameInGame { get; set; }

        [Column(5)]
        public string LeaderName { get; set; }
        
        [Column(6)]
        public string LeaderCharacterName { get; set; }

        [Column(7)]
        public string HowManyGroupMembers { get; set; }

        [Column(8)]
        public string LivingQuartersRequest { get; set; }

        [Column(9)]
        public string SizeAndNumberOfTents { get; set; }

        [Column(10)]
        public string FireplaceNeeded { get; set; }

        [Column(11)]
        public string TypeOfRoleplayRequest { get; set; }

        [Column(12)]
        public string Friends { get; set; }

        [Column(13)]
        public string Enemies { get; set; }

        [Column(14)]
        public string Riches { get; set; }

        [Column(15)]
        public string GroupType { get; set; }

        [Column(16)]
        public string ScenarioWanted { get; set; }

        [Column(17)]
        public string Rumors { get; set; }

        [Column(18)]
        public string Description { get; set; }

        [Column(19)]
        public string GoodToKnow { get; set; }

        [Column(20)]
        public string RulesReadAndAccepted { get; set; }

        [Column(21)]
        public string RightToStoreInformation { get; set; }

        [Column(22)] 
        public string OtherInformation { get; set; }

        [Column(23)]
        public string AlreadyUpdated { get; set; }
    }
}