﻿using Order.Database.Model;
using Order.Service;

namespace Order.Database.Service
{
    internal class ChangeLogService
    {
        public static ChangeLog Add(int productId, int storageId)
        {
            using Context db = new Context();
            int lastResult = 0;
            if (db.ChangeLogs.Count() > 0 && db.ChangeLogs.ToList().Last() != null)
                lastResult = db.ChangeLogs.ToList().Last().Result;
            ChangeLog changeLog = new ChangeLog()
            {
                DateTime = Util.SetKindUtc(DateTime.Now),
                Change = 0,
                ProductId = productId,
                StorageId = storageId,
                Result = lastResult
            };
            db.ChangeLogs.Add(changeLog);
            db.SaveChanges();
            return changeLog;
        }

        public static ChangeLog Update(int id, int change)
        {
            using Context db = new Context();
            ChangeLog? changeLog = db.ChangeLogs.Find(id);

            int lastResult = 0;
            List<ChangeLog> changeLogs = db.ChangeLogs.ToList();
            int lastId = 0;
            if (changeLogs.Count > 1)
                lastId = changeLogs.Count - 2;
            ChangeLog lastChange = changeLogs[lastId];
            if (lastChange != null)
                lastResult = lastChange.Result;


            changeLog.Change = change;
            lastResult += changeLog.Change;
            changeLog.Result = lastResult;
            db.SaveChanges();
            return changeLog;
        }
    }
}
