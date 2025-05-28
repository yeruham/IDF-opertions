public interface Iorganization
{
    string uniqueName { get; set; }
    int SinceThan { get; set; }
    string commander { get; set; }
    string organizationOf { get; set; }
}