using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{

    public class RecyclerService
    {
        public ResultEnum InsertRecycler (Recycler recycler)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                RecyclerDAO dao = new RecyclerDAO();
                dao.InsertRecycler(recycler);
                result = ResultEnum.Fail;
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<Recycler>> getAllRecyclers()
        {
            Result<List<Recycler>> result = new Result<List<Recycler>>();
            try
            {
                RecyclerDAO dao = new RecyclerDAO();
                result.Data = dao.GetAllRecyclers();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
