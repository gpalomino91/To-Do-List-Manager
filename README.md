### # To-Do List Manager

---

### **Description:**
To-Do List Manager is a console application built in C# that allows users to efficiently manage their tasks. Users can add new tasks, view all tasks, mark tasks as completed, and delete tasks when finished.

---

### **Features:**
- **Add New Task:**  
  Add a task with a title and description.
- **View All Tasks:**  
  Display all tasks along with their status (Completed or Pending).
- **Mark Task as Completed:**  
  Mark a task as completed by selecting its number.
- **Delete Task:**  
  Delete a task by selecting its number.
- **Exit:**  
  Safely exit the application.

---

### **Class Design:**
1. **Class: Task**
   - `ID` (int): Unique identifier for each task.
   - `Title` (string): The name of the task.
   - `Description` (string): Details about the task.
   - `IsCompleted` (bool): Status of the task (true = completed, false = pending).

2. **Class: TaskManager**
   - `List<Task> tasks`: A collection of tasks.
   - Methods:
     - `AddTask(Task task)`: Add a new task.
     - `ViewTasks()`: Display all tasks.
     - `CompleteTask(int id)`: Mark a task as completed.
     - `DeleteTask(int id)`: Delete a task by its ID.

3. **Main Class: Program**
   - The main method provides a console-based menu to navigate through the options.

---

### **Menu Structure:**
```
1. Add New Task
2. View All Tasks
3. Mark Task as Completed
4. Delete Task
5. Exit
Select an option:
```

---

### **Technologies Used:**
- C# (.NET 6.0 or later)
- Visual Studio Code or Visual Studio

---

### **Installation & Usage:**
1. Clone the repository:
    ```bash
    git clone https://github.com/gpalominotorres/ToDo-List-Manager.git
    cd ToDo-List-Manager
    ```

2. Open the project in Visual Studio Code or Visual Studio.

3. Build and run the application:
    ```bash
    dotnet build
    dotnet run
    ```

---

### **Contribution:**
Feel free to contribute by:
- Forking the repository
- Creating a new branch (`git checkout -b feature/NewFeature`)
- Making your changes
- Pushing to the branch (`git push origin feature/NewFeature`)
- Creating a Pull Request

---

### **License:**
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

### **Contact:**
- LinkedIn: [Gonzalo Palomino](https://www.linkedin.com/in/gpalominotorres/)
- Email: gpalomino1991@gmail.com

---
