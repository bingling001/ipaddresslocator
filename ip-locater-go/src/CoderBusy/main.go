package main

import (
	"CoderBusy/IPLocater"
	"fmt"
)

func main() {
	fmt.Println("Test Get IP ...")
	ip := "202.102.227.68"
	ipstr := IPLocater.Ips.QueryLocation(ip)
	fmt.Println(ipstr)
}
