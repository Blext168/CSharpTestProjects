using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RouteCalculations.Classes
{
    public class JsonStorage<T>
    {
        private readonly string _filePath;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions() { WriteIndented = true };

        public JsonStorage(string pFilePath)
        {
            _filePath = pFilePath;
        }

        /// <summary>
        /// Asynchronously loads and deserializes a JSON file into a list of objects of type T.
        /// </summary>
        /// <returns>
        /// A list of objects of type T deserialized from the JSON file.
        /// If the file does not exist or deserialization fails, an empty list is returned.
        /// </returns>
        public List<T> LoadAll()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json, _options) ?? new List<T>();
        }

        /// <summary>
        /// Asynchronously saves a list of objects of type T to a JSON file.
        /// </summary>
        /// <param name="items">The list of objects of type T to be serialized and written to the JSON file.</param>
        /// <returns>
        /// A task that represents the asynchronous operation of saving the list to the JSON file.
        /// </returns>
        public void Save(IEnumerable<T> items)
        {
            string json = JsonSerializer.Serialize(items, _options);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Asynchronously adds a single object of type T to the existing list in the JSON file.
        /// If the file does not exist, a new file is created with the given object as the first entry.
        /// </summary>
        /// <param name="item">The object of type T to be added to the JSON storage.</param>
        /// <returns>
        /// A task that represents the asynchronous operation of adding the item to the JSON storage.
        /// </returns>
        public void Add(T item)
        {
            List<T> items = LoadAll();
            items.Add(item);
            Save(items);
        }

        /// <summary>
        /// Asynchronously removes a single object of type T from the existing list in the JSON file.
        /// If the item is not found, the list remains unchanged.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>
        /// A task that represents the asynchronous operation of removing the item from the JSON storage.
        /// </returns>
        public void Remove(Func<T, bool> predicate)
        {
            List<T> items = LoadAll();
            items.RemoveAll(x => predicate(x));
            Save(items);
        }

        /// <summary>
        /// Asynchronously updates an existing item in the JSON data store with the provided updated item.
        /// </summary>
        /// <param name="updatedItem">
        /// The updated object of type T that will replace the existing item in the data store.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result is a boolean indicating whether the update was successful:
        /// true if an item with a matching ID was found and updated, otherwise false.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the type T does not have a property named "Id", which is required to identify items for updates.
        /// </exception>
        public bool Update(T updatedItem)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty is null)
                throw new InvalidOperationException("Typ T mus eine 'Id'-Eingenschaft besitzen.");
            
            List<T> items = LoadAll();
            var updatedId = (int?)idProperty.GetValue(updatedItem);
            
            var index = items.FindIndex(x =>
            {
                var existingId = (int?)idProperty.GetValue(x);
                return existingId == updatedId;
            });
            
            if (index == -1)
                return false; // nothing found
            
            items[index] = updatedItem;
            Save(items);
            return true;
        }
    }
}
