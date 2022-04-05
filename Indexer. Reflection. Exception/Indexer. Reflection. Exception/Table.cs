using Indexer._Reflection._Exception.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer._Reflection._Exception
{
    class Table
    {
        public int Id { get; set; }
        public Table(int id)
        {
            Id = id;
        }

        private Table[] tables = new Table[] { };
        public Table this[int index]
        {
            get
            {
                if (index > 0 && tables.Length > 0)
                {
                    return tables[index];
                }

                else
                {
                    throw new NotAvailableException("Bele bir index yoxdur");
                }

            }

            set
            {
                if (index > 0 && tables.Length > 0)
                {
                    tables[index] = value;
                }
                else
                {
                    throw new NotAvailableException("Bele bir index yoxdur");
                }
            }
        }
    }
}
