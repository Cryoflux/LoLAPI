namespace LoLAPI.Structures.Team
{
    public struct TeamMemberInfoDto
    {
        //This object contains team member information.
        public long inviteDate { get; set; } //Date that team member was invited to team specified as epoch milliseconds.
        public long joinDate { get; set; } //Date that team member joined team specified as epoch milliseconds.
        public long playerId { get; set; }
        public string status { get; set; }
    }
}
