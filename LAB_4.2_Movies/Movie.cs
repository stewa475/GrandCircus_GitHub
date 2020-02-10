using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_4._2_Movies
{
    class Movie
    {
        #region fields
        private string title;
        private string category;
        private int year;
        private int criticsScore;
        private int audienceScore;
        #endregion fields
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        #region properties
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        public int Year { get => year; set => year = value; }
        public int CriticsScore { get => criticsScore; set => criticsScore = value; }
        public int AudienceScore { get => audienceScore; set => audienceScore = value; }
        #endregion properties
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        #region contructors
        public Movie()
        {

        }
        public Movie(string title, string category, int year, int criticsScore, int audienceScore)
        {
            this.title = title;
            this.category = category;
            this.year = year;
            this.criticsScore = criticsScore;
            this.audienceScore = audienceScore;
        }
        #endregion contructors
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        #region methods
        public override string ToString()
        {
            return $" | Title: {Title,-19} | Category: {Category,-10} | Year: {Year,-6} | Critics Score: {CriticsScore,-4} | Audience Score {AudienceScore,-4} |";
        }
        #endregion methods


    }
}