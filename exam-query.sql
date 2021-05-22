




CREATE PROCEDURE usp_getAllStudentBySubject
   @gradeId int
   as
   select * from Students 
   where CurrentGradeId = @gradeId

   CREATE PROCEDURE usp_getGrade
   as
   select * from Grades
GO; 
   

   CREATE PROCEDURE usp_getSubjects
   as
   select * from Subjects
GO; 

