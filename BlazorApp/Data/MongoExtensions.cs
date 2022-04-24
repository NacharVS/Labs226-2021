using System;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class MongoExtensions
    {

        public static void AddItem(List<TaskListItem> user, string nameWeek)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TaskList");
            var collection = database.GetCollection<TaskListItem>(nameWeek);

            for (int i = 0; i < user.Count; i++)
            {
                TaskListItem taskBuf = new TaskListItem(string.Empty)
                {
                    Name = user[i].Name,
                    IsDone = user[i].IsDone,
                    InProgress = user[i].InProgress
                };
                collection.InsertOneAsync(taskBuf);
            }
        }
    }
}