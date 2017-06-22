namespace BashSoft
{
    public static class ExceptionMessages
    {
        //public const string ExampleExceptionMessage = "Example message!";
        public const string DataIsAlreadyInitialized = "Data is already initialized!";

        public const string DataNotInitializedExceptionMessage =
            "The data structure must be initialised first in order to make any operations with it.";

        public const string InexistingCourseInDataBase =
            "The course you are trying to get does not exist in the data base!";

        public const string InexistingStudentInDataBase =
            "The user name for the student you are trying to get does not exist!";

        public const string InvalidPath =
            "The folder/file you are trying to access at the current address, does not exist.";

        public const string UnauthiruzedAccessExceptionMessage =
            "The folder/file you are trying to get access needs a higher level of rights than you currently have";

        public const string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch";

        public const string ForbiddenSymbolsContainedInName =
            "The given name contains symbols that are not allowed to be used in names of files and folders.";

        public const string UnableToGoHigherInPartitionHierarchy = "Unable to go any higher in the partition hierarchy";

        public const string UnableToParseNumber = "The number cannot be parsed";

        public const string InvalidStudentsFilter = "The students filter is not valid!";

        public const string InvalidComparisonQuery =
            "The comparison query you want, does not exist in the context of the current program!";

        public const string InvalidTakeQuantityParameter =
            "The take command expected does not match the format wanted!";

        public const string InvalidTakeCommand =
            "The take command is not supported!";
    }
}