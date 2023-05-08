public with sharing class InstituteUpdateHandler {

    // Method to update the related Student__c records when an Institute__c record is updated
    @InvocableMethod
    public static void updateStudentRecords(List<Id> instituteIds){
        // Get a list of all related Student__c records
        List<Student__c> studentRecords = [SELECT Id, Status__c, LastModifiedDate FROM Student__c WHERE Institute__c IN :instituteIds];
        // Create a list of Student__c records to be updated
        List<Student__c> updateRecords = new List<Student__c>();
        // Calculate the time threshold for an inactive status
        Datetime timeThreshold = Datetime.Now().addDays(-30);
        // Loop through the Student__c records to check if they should be updated
        for (Student__c student : studentRecords) {
            // Check if the Status__c on the Student__c record was created more than 30 days ago
            // and if the Status__c value is not already set to "Inactive"
            if (student.LastModifiedDate < timeThreshold && student.Status__c != 'Inactive') {
                // Set the Status__c to "Inactive"
                student.Status__c = 'Inactive';
                // Add the Student__c record to the list of records to be updated
                updateRecords.add(student);
            }
        }
        // Update all records in the list
        update updateRecords;
    }
}