using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_Test_Interface_3
{
    class MusicFile
    {
        private String title;
        private String artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public String Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public String Artist
        {
            set
            {
                artist = value;
            }
            get
            {
                return artist;
            }
        }
        public int YearOfRelease
        {
            set
            {
                yearOfRelease = value;
            }
            get
            {
                return yearOfRelease;
            }
        }
        public int DurationInSeconds
        {
            set
            {
                durationInSeconds = value;
            }
            get
            {
                return durationInSeconds;
            }
        }


        public MusicFile(String title,String artist,int yearOfRelease,int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;

        }

        void changeTitle(string title)
        {
            this.title = title;
        }

    }
}
