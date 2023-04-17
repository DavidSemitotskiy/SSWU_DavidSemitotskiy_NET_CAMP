﻿namespace exercise_3
{
    public class ApartmentInfo
    {
        private int _id;

        private string _address;

        private string _lastName;

        public ApartmentInfo(int id, string address, string lastName)
        {
            _id = id;
            _address = address;
            _lastName = lastName;
        }

        public int Id => _id;

        public string Address => _address;

        public string LastName => _lastName;
    }
}