package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	var n int
	fmt.Scanln(&n)

	phoneBook := make(map[string]int)

	scanner := bufio.NewScanner(os.Stdin)
	for i := 0; i < n && scanner.Scan(); i++ {
		input := scanner.Text()
		var name string
		var phone int
		fmt.Sscanf(input, "%s %d", &name, &phone)
		phoneBook[name] = phone
	}

	for scanner.Scan() {
		s := scanner.Text()
		if phone, ok := phoneBook[s]; ok {
			fmt.Printf("%s=%d\n", s, phone)
		} else {
			fmt.Println("Not found")
		}
	}
}
