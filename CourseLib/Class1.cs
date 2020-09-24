﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class Courses
    {
        public SortedList<string, Course> sortedList = new SortedList<string, Course>();

        public void Remove(string courseCode)
        {
            if (courseCode != null)
            {
                sortedList.Remove(courseCode);
            }
        }
        public Course this[string courseCode]
        {
            get
            {
                Course returnVal;
                try
                {
                    returnVal = (Course)sortedList[courseCode];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    sortedList[courseCode] = value;
                }
                catch
                {

                }
            }
        }
        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;

            Random rand = new Random();

            // generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // use constructor to create new course object with code and description
                thisCourse = new Course(($"IGME-{i}"), ($"Description for IGME-{i}"));

                // create a new Schedule object
                thisSchedule = new Schedule();
                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of week
                    if (rand.Next(0, 2) == 1)
                    {
                        // add to the daysOfWeek list
                        thisSchedule.daysOfWeek.Add((DayOfWeek)dow);

                        // select random hour of day
                        int nHour = rand.Next(0, 24);

                        // set start and end times of minute duration
                        // select fixed date to allow time calculations
                        thisSchedule.startTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.endTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // set the schedule for this course
                thisCourse.schedule = thisSchedule;

                // add this course to the SortedList
                this[thisCourse.courseCode] = thisCourse;
            }
        }
    }

    public class Schedule
    {
        public DateTime startTime
        {
            get
            {
                return startTime;
            }
            set
            {

            }
        }
        public DateTime endTime
        {
            get
            {
                return endTime;
            }
            set
            {

            }
        }
        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
    }

    public class Course
    {
        public string courseCode
        {
            get
            {
                return courseCode;
            }
            set
            {

            }
        }

        public string description
        {
            get
            {
                return description;
            }
            set
            {

            }
        }

        public string teacherEmail
        {
            get
            {
                return teacherEmail;
            }
            set
            {

            }
        }
        public Schedule schedule
        {
            get
            {
                return schedule;
            }
            set
            {

            }
        }

        public Course(string courseCode, string description)
        {
            this.courseCode = courseCode;
            this.description = description;

        }
    }
}
