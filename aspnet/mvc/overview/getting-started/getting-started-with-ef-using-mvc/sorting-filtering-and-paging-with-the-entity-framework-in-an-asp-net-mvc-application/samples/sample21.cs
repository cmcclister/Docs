public ActionResult About()
{
    IQueryable<EnrollmentDateGroup> data = from student in db.Students
               group student by student.EnrollmentDate into dateGroup
               select new EnrollmentDateGroup()
               {
                   EnrollmentDate = dateGroup.Key,
                   StudentCount = dateGroup.Count()
               };
    return View(data.ToList());
}