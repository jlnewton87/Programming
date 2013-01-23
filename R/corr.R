corr <- function(directory, threshold = 0) {
  
  ids <- complete(threshold)
  coors <- c()
  
  for(num in ids){
    if(num < 10){
      filename <- paste(directory, "\\", "00", as.character(num), ".csv", sep="")
    }#if
    else if(num < 100){
      filename <- paste(directory, "\\", "0", as.character(num), ".csv", sep="")
    }#else if
    else{
      filename <- paste(directory, "\\", as.character(num), ".csv", sep="")
    }#else
    x <- read.csv(filename)
    coors <- c(coors, cor(x$sulfate, x$nitrate,  use="na.or.complete"))
}
  coors
}

complete <- function(threshold) { 

  directory="specdata"
  id=1:332
  ids <- c()
  nobs <- c()
  
  for(num in id){
    if(num < 10){
      filename <- paste(directory, "\\", "00", as.character(num), ".csv", sep="")
    }#if
    else if(num < 100){
      filename <- paste(directory, "\\", "0", as.character(num), ".csv", sep="")
    }#else if
    else{
      filename <- paste(directory, "\\", as.character(num), ".csv", sep="")
    }#else
    x <- read.csv(filename)
    y <- x[complete.cases(x, x$sulfate), ]
    y = y[complete.cases(y, y$nitrate), ]
    if(nrow(y) >= threshold){
      ids <- c(ids, num)
    }
  }
  ids
}