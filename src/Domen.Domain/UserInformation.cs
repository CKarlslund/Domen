using Ganss.Excel;

namespace Domen.Domain;

public class UserInformation
{
	[Column(1)]
	public string Timestamp { get; set; }
	[Column(2)]
	public string Email { get; set; }
	[Column(3)]
	public string NameOffGame { get; set; }
	[Column(4)]
	public string PersonalId { get; set; }
	[Column(5)]
	public int Age { get; set; }
	[Column(6)]
	public string OffNameOfAdult { get; set; }
	[Column(7)]
	public string PhoneNumber { get; set; }
	[Column(8)]
	public string IceContact { get; set; }
	[Column(9)]
	public string OrderFoodAtVenue { get; set; }
	[Column(10)]
	public string AllergicToFood { get; set; }
	[Column(11)]
	public string OtherOffgameInfo { get; set; }
	[Column(12)]
	public string PublicTransport { get; set; }
	[Column(13)]
	public string NeedsFireplace { get; set; }
	[Column(14)]
	public string LivingQuartersRequest { get; set; }
	[Column(15)]
	public string SizeAndNumberOfTents { get; set; }
	[Column(16)]
	public string CaretakerOfHouse { get; set; }
	[Column(17)]
	public string HouseCapacity { get; set; }
	[Column(18)]
	public string InterestedInVolunteerWork { get; set; }
	[Column(19)]
	public string TypeOfVolunteerWork { get; set; }
	[Column(20)]
	public string CharacterName { get; set; }
	[Column(21)]
	public string CharacterDescription { get; set; }
	[Column(22)]
	public string ReligiousBeliefs { get; set; }
	[Column(23)]
	public string ReligiousDescription { get; set; }
	[Column(24)]
	public string CreatureType { get; set; }
	[Column(25)]
	public string CreatureSpecification { get; set; }
	[Column(26)]
	public string CharacterKnowledgeType { get; set; }
	[Column(27)]
	public string CharacterKnowledgeSpecification { get; set; }
	[Column(28)]
	public string ScenarioWanted { get; set; }
	[Column(29)]
	public string MemberOfVillageCouncil { get; set; }
	[Column(30)]
	public string VillageCouncilRole { get; set; }
	[Column(31)]
	public string MemberOfHomeGuard { get; set; }
	[Column(32)]
	public string InterestInHerald { get; set; }
	[Column(33)]
	public string Riches { get; set; }
	[Column(34)]
	public string LegalStatus { get; set; }
	[Column(35)]
	public string OtherOrganizerInfoAboutCharacter { get; set; }
	[Column(36)]
	public string RoleplaySuggestions { get; set; }
	[Column(37)]
	public string Group { get; set; }
	[Column(38)]
	public string HasSeveralRoles { get; set; }
	[Column(39)]
	public string SecondCharacterName { get; set; }
	[Column(40)]
	public string SecondCharacterCreatureTypeAndAbilities { get; set; }
	[Column(41)]
	public string SecondCharacterDescription { get; set; }
	[Column(42)]
	public string SecondCharacterGroup { get; set; }
	[Column(43)]
	public string RulesReadAndAccepted { get; set; }
	[Column(44)]
	public string RightToStoreInformation { get; set; }
	[Column(45)]
	public string MemberOfAssociationAccepted { get; set; }
	[Column(46)]
	public string PayDate { get; set; }
	[Column(47)]
	public string HasPaidMemberFee { get; set; }
	[Column(48)]
	public string HasPaidForFood { get; set; }
	[Column(49)]
	public string CommentFromOrganizer { get; set; }
	[Column(50)]
	public string CommentFromScenarioWriter { get; set; }
}


