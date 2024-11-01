

//this will contain the necassary stuffs for combat
//mattias is gay
//fappy stop fapping
using System;
using System.Windows;


namespace Final_Project
{
    public static class Combat
    {
        //This function willl handle the entire combat, and end when the player dies, the monsters die, or the player flees
        public static void ChooseCombat(Room r, Player p)
        {
            //telling the user they have entered combat, and gives them the option to decline the combat 
            
           
            MessageBoxResult result = MessageBox.Show("You have entered combat with a Level " + r.getEntity(0).getL() + "Enemy", "Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if(result==MessageBoxResult.Yes) {
                DoCombat();
            }
            else {
                MessageBox.Show("You have fled combat you sissy");
            }
        } 

        //the player can either use an item are swing their sword
        //Christopher Strand gave an idea to have multiple windows for combat
        public static void DoCombat() {
            bool combatdone = false;
            
            
            string swingswordmsg = "Swing your sword";
            string useitemmsg = "Use an Item";
            while (combatdone == false) {
                
            }
        }
            
        
    }
    
    


}
