
//this contain rooms for the 2d array logic

//this will do the main stuff with the rooms, and will contain the 2d array
//array stuff is taken from pg 122 of textbook
namespace Final_Project
{

    public static class RoomMethods
    {
        private static int rowsize = 4;
        private static int colsize = 4;
        private static Room[,] DaRooms = new Room[rowsize, colsize];

        

        //this will initialize the rooms as a 2d array
        //array stuff is taken from pg 122 of textbook
        //definately not taken from chatgpt
        static public void Roomsetup()
        {            
            for (int i = 0; i < rowsize; i++)
            {
                for (int j = 0; j < colsize; j++)
                {
                    DaRooms[i, j] = new Room(i,j);
                }
            }
        }

        public static Room[,] GetRooms() { return DaRooms; }

        

        //this function will return the total doors, as well as set the doors of the specific room. 
        static public string GetDoors(int x, int y) //this take in the rooms, as well as the index for the specific room
        {
            string Total_doors = ""; //all of the strings will be concatenated to the total doors
            if (x != 0) { Total_doors += "North"; } //if x is 0, we are in the first row and won't need north doors      

            if (y != (colsize - 1)) { Total_doors += "East"; }//on the last column, and wont need east door

            if (x != (rowsize - 1)) { Total_doors += "South"; } //on the last row, and as such will not the south door 

            if (y != 0) { Total_doors += "West"; } //if y is 0, we are in the first column and thus don't need the west door 

            return Total_doors;
        }

        //note that the room moves update the index inside of player
        //this will be used to schmoove the room, and will return an updated index 
        public static void UpMove(Player p) {p.SetX(p.GetX() - 1);}

        //downschmoove siuuu   
        public static void DownMove(Player p) { p.SetX(p.GetX() + 1); }

        public static void RightMove(Player p) { p.SetY(p.GetY() + 1);}

        public static void LeftMove(Player p) { p.SetY(p.GetY() - 1); }


        // Generate enemies in a random room
        // 2 lv1, 2 lv2, 1 lv3, 1 boss 
        private static void LoadEnemy()
        {
            // This 2 array are to keep track where we already have an enemy, items and the key
            int[] indexI = new int[4];
            int[] indexJ = new int[4];
            
            
            int number;

            Random rng = new Random();

            foreach (var i in DaRooms)
            {
                number = rng.Next(1, rowsize);
                

            }

        }


        // Generate item in the room in a random order
        // 
        private static void LoadItem()
        {

        }

    }
}