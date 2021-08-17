using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secoundBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Oponent oponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            oponent = new Oponent(frontYard);
            ResetGame(false);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan","dębowe drzwi","szafa");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "żyrandol","wysoka szafa");
            kitchen = new RoomWithDoor("Kuchnia", "sztućce", "drzwi","szafka");

            stairs = new Room("Schody", "poręcz");
            hallway = new RoomWithHidingPlace("Korytarz", "obraz", "szafa ścienna");
            bathroom = new RoomWithHidingPlace("Łazienka", "kibel", "prysznic");
            masterBedroom = new RoomWithHidingPlace("Sypialnia", "duże łoże", "pod łóżkiem");
            secoundBedroom = new RoomWithHidingPlace("Druga sypialnia", "duże łoże", "pod łóżkiem");


            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false,"szopa");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };

            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secoundBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secoundBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }
        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (oponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 1; i <= 10; i++)
            {
                oponent.Move();
                description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Gotowy czy nie - nadchodzę";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
