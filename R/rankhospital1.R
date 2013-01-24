rankhospital1 <- function(state, outcome, num = "best") { 
  source('unique.R')
  outcomes = c('heart attack', 'heart failure', 'pneumonia')
  outcome1 = read.csv("outcome-of-care-measures.csv", 
                      colClasses="character")
  diseaseCol = 0
  outcome1[, 11] <- as.numeric(outcome1[, 11])
  outcome1[, 17] <- as.numeric(outcome1[, 17])
  outcome1[, 23] <- as.numeric(outcome1[, 23])
  if(outcome == 'heart attack')
  {
    diseaseCol = 11
  }
  if(outcome == 'heart failure')
  {
    diseaseCol = 17
  }
  if(outcome == 'pneumonia')
  {
    diseaseCol = 23
  }
  
  ## Check that state and outcome are valid
  if(!state %in% Unique(outcome1[, 7]))
  {
    stop("invalid state") 
  }
  if(!outcome %in% outcomes)
  {
    stop("invalid outcome")
  }
  ## Return hospital name in that state with the given rank ## 30-day death rate
  state1 = outcome1[which(outcome1$State == state),]
  
  state1 = state1[order(state1$Hospital.Name),]
  if(diseaseCol == 11)
  {
    state1 = state1[order(state1$Hospital.30.Day.Death..Mortality..Rates.from.Heart.Attack),]
    state1 = state1[,c(2,7,diseaseCol)]
  }
  if(diseaseCol == 17)
  {
    state1 = state1[order(state1$Hospital.30.Day.Death..Mortality..Rates.from.Heart.Failure),]
    state1 = state1[,c(2,7,diseaseCol)]
  }
  if(diseaseCol == 23)
  {
    state1 = state1[order(state1$Hospital.30.Day.Death..Mortality..Rates.from.Pneumonia),]
    state1 = state1[,c(2,7,diseaseCol)]
  }
  state1=state1[complete.cases(state1),]
  if(num=='worst'){num = nrow(state1)}
  if(num=='best'){num = 1}
  hos = state1[num,]
  return(data.frame(rbind(c(hospital = hos$Hospital.Name, state = hos$State))))
  
}
