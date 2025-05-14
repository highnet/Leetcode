/*
Given a valid (IPv4) IP address, return a defanged version of that IP address.

A defanged IP address replaces every period "." with "[.]".
*/

class Solution(object):
    def defangIPaddr(self, address):
        fanged = ""
        for char in address:
            if (char == '.'):
                fanged += ("[.]")
            else:
                fanged += (char)
        return fanged
