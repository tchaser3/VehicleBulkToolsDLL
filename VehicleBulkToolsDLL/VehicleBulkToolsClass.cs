/* Title:           Vehicle Bulk Tools Class
 * Date:            5-25-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for the vehicle bulk tools*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleBulkToolsDLL
{
    public class VehicleBulkToolsClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        VehicleBulkToolsDataSet aVehicleBulkToolsDataSet;
        VehicleBulkToolsDataSetTableAdapters.vehiclebulktoolsTableAdapter aVehicleBulkToolsTableAdapter;

        InsertVehicleBulkToolsEntryTableAdapters.QueriesTableAdapter aInsertVehicleBulkToolsTableAdapter;

        UpdateVehicleBulkToolsEntryTableAdapters.QueriesTableAdapter aUpdateVehicleBulkToolsTableAdapters;

        FindVehicleBulkToolDataSet aFindVehicleBulkToolDataSet;
        FindVehicleBulkToolDataSetTableAdapters.FindVehicleBulkToolTableAdapter aFindVehicleBulkToolTableAdapter;

        FindAllBulkToolsForVehicleDataSet aFindAllBulkToolsForVehicleDataSet;
        FindAllBulkToolsForVehicleDataSetTableAdapters.FindAllBulkToolsForVehicleTableAdapter aFindAllBulkToolsForVehicleTableAdapter;

        FindVehicleBulkToolByTransactionIDDataSet aFindVehicleBulkToolByTransactionIDDataSet;
        FindVehicleBulkToolByTransactionIDDataSetTableAdapters.FindVehicleBulkToolByTransactionIDTableAdapter aFindVehicleBulkToolByTransactionIDTableAdapter;

        FindVehicleBulkToolByVehicleNumberDataSet aFindVehicleBulkToolByVehicleNumberDataSet;
        FindVehicleBulkToolByVehicleNumberDataSetTableAdapters.FindVehicleBulkToolByVehicleNumberTableAdapter aFindVehicleBulkToolByVehicleNumberTableAdapter;

        public FindVehicleBulkToolByVehicleNumberDataSet FindVehicleBulkToolByVehicleNumber(string strVehicleNumber)
        {
            try
            {
                aFindVehicleBulkToolByVehicleNumberDataSet = new FindVehicleBulkToolByVehicleNumberDataSet();
                aFindVehicleBulkToolByVehicleNumberTableAdapter = new FindVehicleBulkToolByVehicleNumberDataSetTableAdapters.FindVehicleBulkToolByVehicleNumberTableAdapter();
                aFindVehicleBulkToolByVehicleNumberTableAdapter.Fill(aFindVehicleBulkToolByVehicleNumberDataSet.FindVehicleBulkToolByVehicleNumber, strVehicleNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tool Class // Find Vehicle Bulk Tool By Vehicle Number " + Ex.Message);
            }

            return aFindVehicleBulkToolByVehicleNumberDataSet;
        }
        public FindVehicleBulkToolByTransactionIDDataSet FindVehicleBulkToolByTransactionID(int intTransactionID)
        {
            try
            {
                aFindVehicleBulkToolByTransactionIDDataSet = new FindVehicleBulkToolByTransactionIDDataSet();
                aFindVehicleBulkToolByTransactionIDTableAdapter = new FindVehicleBulkToolByTransactionIDDataSetTableAdapters.FindVehicleBulkToolByTransactionIDTableAdapter();
                aFindVehicleBulkToolByTransactionIDTableAdapter.Fill(aFindVehicleBulkToolByTransactionIDDataSet.FindVehicleBulkToolByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tools Class // Find Vehicle Bulk Tool By Transaction ID " + Ex.Message);
            }

            return aFindVehicleBulkToolByTransactionIDDataSet;
        }
        public FindAllBulkToolsForVehicleDataSet FindAllBulkToolsForVehicle(string strVehicleNumber)
        {
            try
            {
                aFindAllBulkToolsForVehicleDataSet = new FindAllBulkToolsForVehicleDataSet();
                aFindAllBulkToolsForVehicleTableAdapter = new FindAllBulkToolsForVehicleDataSetTableAdapters.FindAllBulkToolsForVehicleTableAdapter();
                aFindAllBulkToolsForVehicleTableAdapter.Fill(aFindAllBulkToolsForVehicleDataSet.FindAllBulkToolsForVehicle, strVehicleNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tool Class // Find All Bulk Tools For Vehicle " + Ex.Message);
            }

            return aFindAllBulkToolsForVehicleDataSet;
        }
        public FindVehicleBulkToolDataSet FindVehicleBulkTool(string strVehicleNumber, string strToolCategory)
        {
            try
            {
                aFindVehicleBulkToolDataSet = new FindVehicleBulkToolDataSet();
                aFindVehicleBulkToolTableAdapter = new FindVehicleBulkToolDataSetTableAdapters.FindVehicleBulkToolTableAdapter();
                aFindVehicleBulkToolTableAdapter.Fill(aFindVehicleBulkToolDataSet.FindVehicleBulkTool, strVehicleNumber, strToolCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tool Class // Find Vehicle Bulk Tool " + Ex.Message);
            }

            return aFindVehicleBulkToolDataSet;
        }
        public bool UpdateVehicleBulkTools(int intTransactionID, int intQuantity)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleBulkToolsTableAdapters = new UpdateVehicleBulkToolsEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleBulkToolsTableAdapters.UpdateVehicleBulkToolsQuantity(intTransactionID, intQuantity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tools Class // Update Vehicle Bulk Tools " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertVehicleBulkTools(int intVehicleID, int intCategoryID, int intQuantity)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleBulkToolsTableAdapter = new InsertVehicleBulkToolsEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleBulkToolsTableAdapter.InsertVehicleBulkTools(intVehicleID, intCategoryID, intQuantity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tools Class // Insert Vehicle Bulk Tools " + Ex.Message);
            }

            return blnFatalError;
        }
        public VehicleBulkToolsDataSet GetVehicleBulkToolsInfo()
        {
            try
            {
                aVehicleBulkToolsDataSet = new VehicleBulkToolsDataSet();
                aVehicleBulkToolsTableAdapter = new VehicleBulkToolsDataSetTableAdapters.vehiclebulktoolsTableAdapter();
                aVehicleBulkToolsTableAdapter.Fill(aVehicleBulkToolsDataSet.vehiclebulktools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tools Class // Get Vehicle Bulk Tools Info " + Ex.Message);
            }

            return aVehicleBulkToolsDataSet;
        }
        public void UpdateVehicleBulkToolsDB(VehicleBulkToolsDataSet aVehicleBulkToolsDataSet)
        {
            try
            {
                aVehicleBulkToolsTableAdapter = new VehicleBulkToolsDataSetTableAdapters.vehiclebulktoolsTableAdapter();
                aVehicleBulkToolsTableAdapter.Update(aVehicleBulkToolsDataSet.vehiclebulktools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Bulk Tools Class // Update Vehicle Bulk Tools DB " + Ex.Message);
            }
        }
    }
}
