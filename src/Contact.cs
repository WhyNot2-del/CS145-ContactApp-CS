﻿using System;

public class Contact : IComparable<Contact>
{
    private string fName;
    private string lName;
    private string phoneNum;
    private string address;
    private int zipCode;
    private string email;

    public Contact(string fName, string lName, string phoneNum, string address, int zipCode, string email)
    {
        this.fName = fName;
        this.lName = lName;
        this.phoneNum = phoneNum;
        this.address = address;
        this.zipCode = zipCode;
        this.email = email;
    }

    public Contact(string fName, string lName, string phoneNum)
    {
        this.fName = fName;
        this.lName = lName;
        this.phoneNum = phoneNum;
    }



    // override
    public int CompareTo(Contact inputName)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        bool fNameEnd = false;
        bool inputFNameEnd = false;
        int charCounter = 1;
        int fNameIndex;
        int inputFNameIndex;

        fNameIndex = chars.IndexOf(this.fName.ToLower().ToCharArray()[0]);
        inputFNameIndex = chars.IndexOf(inputName.fName.ToLower().ToCharArray()[0]);

        if (inputFNameIndex > fNameIndex)
        {
            return 1;
        } else if (inputFNameIndex < fNameIndex)
        {
            return -1;
        }

        while (true)
        {
            try
            {
                fNameIndex = chars.IndexOf(this.fName.ToLower().ToCharArray()[charCounter]);
            }
            catch (IndexOutOfRangeException e)
            {
                fNameEnd = true;
            }

            try
            {
                inputFNameIndex = chars.IndexOf(inputName.fName.ToLower().ToCharArray()[charCounter]);
            }
            catch (IndexOutOfRangeException e)
            {
                inputFNameEnd = true;
            }

            if (fNameEnd && inputFNameEnd)
            {
                return lNameCompare(inputName);
            }
            else if (inputFNameEnd)
            {
                return 1;
            }
            else if (fNameEnd)
            {
                return -1;
            }
            else
            {
                if (inputFNameIndex > fNameIndex)
                {
                    return 1;
                }
                else if (inputFNameIndex < fNameIndex)
                {
                    return -1;
                }
            }
            charCounter++;
        }
    }

    private int lNameCompare(Contact inputName)
    {

    }
}