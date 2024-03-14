export type Bowler = {
  team: any;
  bowlerId: number;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerLastName: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  teamName: Team;
};

export type Team = {
  teamId: number;
  teamName: string;
  // Add other properties of the Team table if needed
};
