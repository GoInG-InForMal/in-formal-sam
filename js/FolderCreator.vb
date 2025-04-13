Imports System.IO

Module FolderCreator

    Sub Main()
        ' Define the root folder name
        Dim rootFolderName As String = "Engine"

        ' Determine the current drive (you can modify this if needed)
        Dim currentDrive As String = Path.GetPathRoot(Directory.GetCurrentDirectory())

        ' Construct the full root path
        Dim rootPath As String = Path.Combine(currentDrive, rootFolderName)

        ' Define the rest of your folder structure
        Dim [structure] As String() = {
            Path.Combine(rootPath, "InForMal", "SAM", "Website"),
            Path.Combine(rootPath, "InForMal", "SAM", "MobileApp"),
            Path.Combine(rootPath, "InForMal", "SAM.Dev", "Projects"),
            Path.Combine(rootPath, "InForMal", "[Another Sub-Brand]"),
            Path.Combine(rootPath, "InForMal", "SW_Development", "[AppName]"),
            Path.Combine(rootPath, "Formal", "[Sub-Brand Name]"),
            Path.Combine(rootPath, "Formal", "SW_Development", "[LibraryName]"),
            Path.Combine(rootPath, "Departments", "IT", "Infrastructure"),
            Path.Combine(rootPath, "Departments", "IT", "Support"),
            Path.Combine(rootPath, "Departments", "IT", "Projects"),
            Path.Combine(rootPath, "Departments", "Accounting", "Financial Reports"),
            Path.Combine(rootPath, "Departments", "Accounting", "Invoices"),
            Path.Combine(rootPath, "Departments", "Accounting", "Payroll"),
            Path.Combine(rootPath, "Departments", "Marketing", "Campaigns"),
            Path.Combine(rootPath, "Departments", "Marketing", "Content"),
            Path.Combine(rootPath, "Departments", "Marketing", "Analytics"),
            Path.Combine(rootPath, "Departments", "Legal", "Contracts"),
            Path.Combine(rootPath, "Departments", "Legal", "Policies"),
            Path.Combine(rootPath, "Departments", "Legal", "Intellectual Property"),
            Path.Combine(rootPath, "Departments", "HR", "Employee Records"),
            Path.Combine(rootPath, "Departments", "HR", "Recruitment"),
            Path.Combine(rootPath, "Departments", "HR", "Training"),
            Path.Combine(rootPath, "Common", "Templates"),
            Path.Combine(rootPath, "Common", "Policies"),
            Path.Combine(rootPath, "Docs"),
            Path.Combine(rootPath, "Assets")
        }

        ' Create the root folder if it doesn't exist
        If Not Directory.Exists(rootPath) Then
            Directory.CreateDirectory(rootPath)
            Console.WriteLine($"Created root folder: {rootPath}")
            ' Create the "Initiate Folder.txt" in the root
            File.CreateText(Path.Combine(rootPath, "Initiate Folder.txt")).Dispose()
            Console.WriteLine($"Created 'Initiate Folder.txt' in: {rootPath}")
        End If

        ' Create the rest of the folders and "Initiate Folder.txt" in each
        For Each folderPath As String In [structure]
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
                Console.WriteLine($"Created folder: {folderPath}")
            End If
            ' Create the "Initiate Folder.txt" in each folder
            File.CreateText(Path.Combine(folderPath, "Initiate Folder.txt")).Dispose()
            Console.WriteLine($"Created 'Initiate Folder.txt' in: {folderPath}")
        Next

        Console.WriteLine("Folder structure creation complete!")
        Console.ReadKey() ' Keep the console window open
    End Sub

End Module