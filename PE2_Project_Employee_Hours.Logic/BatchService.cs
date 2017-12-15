using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Data;
using System.Data;

namespace PE2_Project_Employee_Hours.Logic
{
    public class BatchService
    {
        public ResultEnum InsertBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;

            try
            {
                BatchDAO dao = new BatchDAO();
                dao.InsertBatch(batch);
                

            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum UpdateBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;

            try
            {
                BatchDAO dao = new BatchDAO();
                dao.UpdateBatch(batch);


            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum DeleteBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;
            
            try
            {
                BatchDAO dao = new BatchDAO();
                dao.DeleteBatch(batch);


            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<Batch>> GetAllBatches()
        {
            //null result
            Result<List<Batch>> result = new Result<List<Batch>>();
            result.Status = ResultEnum.Success;
            try
            {
                BatchDAO dao = new BatchDAO();
                result.Data = dao.GetAllBatches();

            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<DataTable> GetAllBatchesDT()
        {
            //null result
            Result<DataTable> result = new Result<DataTable>();
            result.Status = ResultEnum.Success;
            try
            {
                BatchDAO dao = new BatchDAO();
                result.Data = dao.GetAllBatchesDT();

            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
