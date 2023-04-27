List<int> the_List = new List<int>(){1, 5, 6, 3, 2, 3, 4, 1, 2, 3, 4, 2};

// open the cookie trail
List<int> been_to = new List<int>(){0};

bool search_branch(int index) {
    if (index == the_List.Count - 1) {
        return true;
    }
    else if (been_to.Contains(index)) {
        return false;
    }
    
    been_to.Add(index);

    int move = the_List[index];

    if (index + move <= the_List.Count - 1) {
        if (search_branch(index + move)) {
            return true;
        }
    }
    if (index - move > 0 ) {
        if (search_branch(index - move)) {
            return true;
        }
    }
    return false;
}

void main() {
    if (the_List[0] < the_List.Count) {
        if (search_branch(the_List[0])) {
            Console.Write("List is compleatable");
        }
        else {
            Console.Write("List is incompleatable");
        }
    }
    else {
        Console.Write("List is incompleatable");
    }

 // debug mode
 //   for (int i = 1; i < been_to.Count; i++) {
 //       Console.Write("\n" + been_to[i]);
 //   }
}

main();