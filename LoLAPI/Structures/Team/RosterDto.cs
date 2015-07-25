using System.Collections.Generic;

namespace LoLAPI.Structures.Team
{
    public struct RosterDto
    {
        //This object contains roster information.
        public List<TeamMemberInfoDto> memberList { get; set; }
        public long ownerId { get; set; }
    }
}
