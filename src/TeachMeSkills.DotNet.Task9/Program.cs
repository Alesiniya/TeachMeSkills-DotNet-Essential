using System;

namespace TeachMeSkills.DotNet.Task9
{
    public abstract class Pupil
    {
        string _name;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
        public Pupil(string name)
        {
            Name = name;
        }
        public abstract void Display();
    }
    public class ClassRoom
    {
        public Pupil pupil1;
        public Pupil pupil2;
        public Pupil pupil3;
        public Pupil pupil4;
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Random rand = new Random();
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            switch (rand.Next(3))
            {
                case 1:
                    this.pupil3 = new ExcellentPupil("Mike");
                    this.pupil4 = new GoodPupil("Bob");
                    break;
                case 2:
                    this.pupil3 = new GoodPupil("Mike");
                    this.pupil4 = new BadPupil("Bob");
                    break;
                case 3:
                    this.pupil3 = new BadPupil("Mike");
                    this.pupil4 = new ExcellentPupil("Bob");
                    break;
            }
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Random rand = new Random();
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            switch (rand.Next(3))
            {
                case 1:
                    this.pupil4 = new GoodPupil("Bob");
                    break;
                case 2:
                    this.pupil4 = new BadPupil("Bob");
                    break;
                case 3:
                    this.pupil4 = new ExcellentPupil("Bob");
                    break;
            }
        }
        public void Display()
        {
            Console.WriteLine("--------CLASS ROOM--------");
            pupil1.Display();
            pupil2.Display();
            pupil3.Display();
            pupil4.Display();
        }
    }
    public class ExcellentPupil:Pupil
    {
        private string quality = "Excellent";
        public ExcellentPupil(string name)
            :base(name)
        {
            Console.WriteLine("New EX Pupil created.");
        }
        public override void Study()
        {
            Console.WriteLine("Study : Excellent pupil.");
        }
        public override void Read()
        {
            Console.WriteLine("Read : Excellent pupil.");
        }
        public override void Write()
        {
            Console.WriteLine("Write : Excellent pupil.");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax : Excellent pupil.");
        }
        public override void Display()
        {
            Console.WriteLine("Name - {0}; Type - {1}", Name, quality);
        }
    }
    public class GoodPupil : Pupil
    {
        public string quality = "Good";
        public GoodPupil(string name)
            : base(name)
        {
            Console.WriteLine("New GoodPupil created.");
        }
        public override void Study()
        {
            Console.WriteLine("Study : Good Pupul.");
        }
        public override void Read()
        {
            Console.WriteLine("Read : Good Pupil.");
        }
        public override void Write()
        {
            Console.WriteLine("Write : Good Pupil.");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax : Good Pupil.");
        }
        public override void Display()
        {
            Console.WriteLine("Name - {0}; Type - {1}", Name, quality);
        }
    }
    public class BadPupil : Pupil
    {
        public string quality = "Bad";
        public BadPupil(string name)
            :base(name)
        {
            Console.WriteLine("New Bad Pupil created.");
        }
        public override void Study()
        {
            Console.WriteLine("Study : Bad Pupil.");
        }
        public override void Read()
        {
            Console.WriteLine("Read : Bad Pupil.");
        }
        public override void Write()
        {
            Console.WriteLine("Write : Bad Pupil.");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax : Bad Pupil.");
        }
        public override void Display()
        {
            Console.WriteLine("Name - {0}; Type - {1}", Name, quality);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new ExcellentPupil("Gerry");
            Pupil pupil2 = new GoodPupil("Julia");
            Pupil pupil3 = new BadPupil("John");
            ClassRoom classRoom = new ClassRoom(pupil1, pupil2);
            ClassRoom classRoom1 = new ClassRoom(pupil1, pupil2, pupil3);
            Console.WriteLine("Class Room : ");
            classRoom.Display();
            classRoom.pupil1.Study();
            classRoom.pupil2.Study();
            classRoom.pupil3.Study();
            classRoom.pupil4.Study();
            Console.WriteLine("Class Room 1 : ");
            classRoom1.Display();
            classRoom1.pupil1.Relax();
            classRoom1.pupil2.Relax();
            classRoom1.pupil3.Relax();
            classRoom1.pupil4.Relax();
        }
    }
}
