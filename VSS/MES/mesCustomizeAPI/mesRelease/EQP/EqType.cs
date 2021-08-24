using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.EQP;

namespace mesRelease.EQP
{
    public class EqType : eqType<EqType>
    {
        public EqType() : base() { }
        public EqType(string name) : base(name) { }

        protected override void OnInit(System.Data.DataRow row)
        {

        }
        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        EqTypeParameter[] _params = null;
        void retrieveParams()
        {
            if (_params == null || parmFlag)
            {
                parmFlag = false;
                if (parameterCount == 0)
                    _params = new EqTypeParameter[] { };
                else
                    _params = EqTypeParameter.GetEqTypeParameters(name);
            }
        }
        public EqTypeParameter[] GetEqParameters()
        {
            retrieveParams();
            return _params;
        }
        public EqTypeParameter GetEqParameter(int index)
        {
            retrieveParams();
            if (index >= 0 && index < _params.Length)
                return _params[index];
            else
                return null;
        }
        public EqTypeParameter GetEqParameter(string name)
        {
            retrieveParams();
            foreach (EqTypeParameter p in _params)
            {
                if (p.name.Equals(name))
                    return p;
            }
            return null;
        }

        public EqTypeParameter GetEqParameterByEqDataId(string dataId)
        {
            retrieveParams();
            foreach (EqTypeParameter p in _params)
            {
                if (p.eqDataId.Equals(dataId))
                    return p;
            }
            return null;
        }
    }
}
