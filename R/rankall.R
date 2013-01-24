rankall <- function(outcome, num = "best") { 
  source('rankhospital1.R')
  state = c("AK","AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "GU", 
"HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", 
"MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", 
"NV", "NY", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD", "TN", 
"TX", "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY")
  states = c()
  hospitals = c()
  for(i in state)
    {
      x = rankhospital1(i, outcome, num)
      states = c(states, as.character(x$state))
      hospitals = c(hospitals, as.character(x$hospital))
    }
  data.frame(hospital = hospitals, state = states)
}