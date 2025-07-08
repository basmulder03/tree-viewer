using Spectre.Console;

var inputPath = args.Length > 0 ? args[0] : ".";
var maxDepth = args.Length > 1 && int.TryParse(args[1], out var d) ? d : 10;

var fullPath = Path.GetFullPath(inputPath);
if (!Directory.Exists(fullPath))
{
    AnsiConsole.MarkupLine($"[red]Directory not found:[/] {fullPath}");
    return;
}

var tree = BuildTree(fullPath, maxDepth);
AnsiConsole.Write(tree);
return;

static Tree BuildTree(string path, int maxDepth, int currentDepth = 0)
{
    var dir = new DirectoryInfo(path);
    var tree = new Tree($"[blue]{dir.Name}[/]");
    AddNodes(tree, dir, maxDepth, currentDepth);
    return tree;
}

static void AddNodes(IHasTreeNodes parent, DirectoryInfo dir, int maxDepth, int depth)
{
    if (depth >= maxDepth) return;

    try
    {
        foreach (var subDir in dir.GetDirectories())
        {
            var node = parent.AddNode($"[blue]{subDir.Name}[/]");
            AddNodes(node, subDir, maxDepth, depth + 1);
        }

        foreach (var file in dir.GetFiles())
        {
            parent.AddNode(file.Name);
        }
    }
    catch (UnauthorizedAccessException)
    {
        parent.AddNode("[red]Access denied[/]");
    }
}