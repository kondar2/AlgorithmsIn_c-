private List<Node> nodes;
private Node root;

public List<string> GetHuffmanCode(string input)
{
    if (input.Length == 0)
    {
        return new List<string>();
    }

    PrepareInput(input);
    if (nodes.Count == 0)
    {
        var list = new List<string>();
        foreach (var item in input)
        {
            list.Add("0");
        }
        return list;
    }
    ModifyNodes(nodes);

    var symbolMap = GetSymbolMap();

    var res = new List<string>();
    foreach (var item in input)
    {
        res.Add(symbolMap[item.ToString()]);
    }

    return res;
}

public Dictionary<string, string> GetSymbolMap()
{
    var symbolMap = new Dictionary<string, string>();

    foreach (var item in nodes)
    {
        var code = item.GetCode();
        symbolMap.Add(item.symbol, item.GetCode());
    }
    return symbolMap;
}


public void PrintTree()
{
    if (nodes.Count == 0)
    {
        return;
    }
    root.Display(0);
}


public void PrintCodeTable()
{
    //var list = nodes.OrderBy(el => -el.frequency).ToList();

    Console.WriteLine("\n{0, -10}{1, -10}{2, -10}", "symbol", "frequency", "code");
    foreach (var item in nodes)
    {
        var code = item.GetCode();
        Console.WriteLine("{0, -10}{1, -10}{2, -20}", item.symbol, item.frequency, code);
    }
}

private void PrepareInput(string input)
{
    var symbolCounts = input.GroupBy(symbol => symbol)
        .ToDictionary(g => g.Key, g => g.Count());
    nodes = new List<Node>();
    if (symbolCounts.Count == 1)
    {
        return;
    }

    foreach (var item in symbolCounts)
    {
        nodes.Add(new Node(item.Key.ToString(), item.Value));
        //nodes.Add(new Node(item.Key.ToString(), Convert.ToDouble(item.Value) / input.Count()));
    }
}

private void ModifyNodes(List<Node> nodes)
{
    nodes.Sort();
    if (nodes.Count == 1)
    {
        return;
    }

    var last = nodes[nodes.Count - 1];
    last.code = "0";
    var lastBeforeLast = nodes[nodes.Count - 2];
    lastBeforeLast.code = "1";

    var node = new Node(lastBeforeLast.symbol + last.symbol, lastBeforeLast.frequency + last.frequency);
    node._children.Add(lastBeforeLast);
    node._children.Add(last);
    last.parentNode = node;
    lastBeforeLast.parentNode = node;

    var newList = new List<Node>(nodes.Take(nodes.Count - 2));
    newList.Add(node);

    if (newList.Count == 1)
    {
        root = node;
    }
    ModifyNodes(newList);
    return;

}