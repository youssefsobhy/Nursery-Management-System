﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nursery_Management_System
{
    class SQLQuery
    {
        public SQLQuery() { }
        
        public void insertChildData(ChildClass child)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertChildData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@childName", child.firstName);
            mCommand.Parameters.AddWithValue("@parentID", child.parentID);
            mCommand.Parameters.AddWithValue("@DOB", child.DOB);
            mCommand.Parameters.AddWithValue("@gender", child.gender);
            mCommand.Parameters.AddWithValue("@picture", child.image);
            mCommand.Parameters.AddWithValue("@roomID", child.roomID);

            mSQL.insertQuery(mCommand);

            return;
        }
        public void insertParentData(Parent parent)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertParentData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@parentID", parent.id);
            mCommand.Parameters.AddWithValue("@parentFirstName", parent.firstName);
            mCommand.Parameters.AddWithValue("@parentLastName", parent.lastName);
            mCommand.Parameters.AddWithValue("@parentAddress", parent.address);
            mCommand.Parameters.AddWithValue("@parentPhoneNumber", parent.phoneNumber);
            mCommand.Parameters.AddWithValue("@parentCreditCard", parent.creditCard);
            mCommand.Parameters.AddWithValue("@parentEmail", parent.email);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertStaffData(Staff staff , int department)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertParentData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@staffID", staff.id);
            mCommand.Parameters.AddWithValue("@staffFirstName", staff.firstName);
            mCommand.Parameters.AddWithValue("@staffLasttName", staff.lastName);
            mCommand.Parameters.AddWithValue("@staffPhoneNumber", staff.phoneNumber);
            mCommand.Parameters.AddWithValue("@staffEmail", staff.email);
            mCommand.Parameters.AddWithValue("@staffSalary", staff.salary);
            mCommand.Parameters.AddWithValue("@staffDepartment", department);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertRoom(Room room)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertRoomData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@roomNumber", room.number);
            if(room.staffID == -1)
                mCommand.Parameters.AddWithValue("@roomStaffID", DBNull.Value);
            else
                mCommand.Parameters.AddWithValue("@roomStaffID", room.staffID);
            mSQL.insertQuery(mCommand);

            return;
        }

        public void updateChildData()
        {

        }

        public void updateParentData()
        {

        }

        public void updateStaffData()
        {
            
        }
    }
}
